using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hairology
{
    public class Product
    {
        // product attributes
        private string _productName = default!;
        private string _productDescription = default!;
        private string _category = default!;
        private string _eanNumber = default!;
        private int _caseSize = default!;
        private int _currentQuantity = default!;
        private bool _reorderRegularly = default!;
        // constructor
        public Product(object[] productDetails)
        {
            _productName = productDetails[0].ToString();
            _productDescription = productDetails[1].ToString();
            _category = productDetails[2].ToString();
            _eanNumber = productDetails[3].ToString();
            _caseSize = Int32.Parse(productDetails[4].ToString());
            _currentQuantity = Int32.Parse(productDetails[5].ToString());
            _reorderRegularly = bool.Parse(productDetails[6].ToString());
        }
        public object GetAttribute(int index)
        {
            switch (index)
            {
                case 0:
                    return _productName;
                case 1:
                    return _productDescription;
                case 2:
                    return _category;
                case 3:
                    return _eanNumber;
                case 4:
                    return _caseSize;
                case 5:
                    return _currentQuantity;
                case 6:
                    return _reorderRegularly;
                default:
                    return null;
            }
        }
    }
}
