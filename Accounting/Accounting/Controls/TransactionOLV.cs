using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BrightIdeasSoftware;
using Accounting.Model;

namespace Accounting.Controls
{
    public class TransactionOLV : ObjectListView
    {
        public enum FilterType
        {
            CONTAINS = 0,
            PREFIX,
            REGEX
        };

        public void Initialize()
        {
            this.InitializeProperties();

            InitializeDataModel();
        }

        private void InitializeProperties()
        {
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FullRowSelect = true;
            this.GridLines = true;
            this.HasCollapsibleGroups = false;
            this.ShowGroups = false;
            this.UseFilterIndicator = true;
            this.UseFiltering = true;
            this.UseHotItem = true;
            this.UseTranslucentHotItem = true;
            this.View = System.Windows.Forms.View.Details;
        }

        private void InitializeDataModel()
        {
            Generator.GenerateColumns(this, typeof(Record), false);
        }

        public void TimeFilter( String aFilterStr )
        {
            this.TimeFilter( aFilterStr, FilterType.CONTAINS );
        }

        public void TimeFilter( String aFilterStr, FilterType aType )
        {
            TextMatchFilter nFilter = null;
            if ( !String.IsNullOrEmpty( aFilterStr ) )
            {
                switch ( aType )
                {
                    default:
                    case FilterType.CONTAINS:
                        nFilter = TextMatchFilter.Contains( this, aFilterStr );
                        break;
                    case FilterType.PREFIX:
                        nFilter = TextMatchFilter.Prefix( this, aFilterStr );
                        break;
                    case FilterType.REGEX:
                        nFilter = TextMatchFilter.Regex( this, aFilterStr );
                        break;
                }
            }

            if ( nFilter == null )
                this.DefaultRenderer = null;
            else
                this.DefaultRenderer = new HighlightTextRenderer( nFilter );

            // Some lists have renderers already installed
            HighlightTextRenderer highlightingRenderer = this.GetColumn( 0 ).Renderer as HighlightTextRenderer;
            if ( highlightingRenderer != null )
                highlightingRenderer.Filter = nFilter;

            this.AdditionalFilter = nFilter;
        }
    }
}
