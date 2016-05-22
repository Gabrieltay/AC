using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Accounting.Model;

namespace Accounting.Controls
{
    public class CodeOLV : BaseOLV<GLCode>
    {
        new public void Initialize()
        {
            base.Initialize();
        }

        new public void Sort()
        {
            this.Sort( 0 );
        }
    }

    public class TransactionOLV : BaseOLV<Record>
    {
        new public void Initialize()
        {
            base.Initialize();
        }

        new public void Sort()
        {
            this.Sort( 0 );
        }
    }

    public class TrialBalanceOLV : BaseOLV<TrialBalanceItem>
    {
        new public void Initialize()
        {
            base.Initialize();
        }

        new public void Sort()
        {
            this.Sort( 0 );
        }
    }
}
