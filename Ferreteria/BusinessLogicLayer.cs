using System;
using System.Collections.Generic;
using System.Text;

namespace Ferreteria
{
    class BusinessLogicLayer
    {
        private DataAccessLayer _dataAccessLayer;

        public BusinessLogicLayer()
        {
            _dataAccessLayer = new DataAccessLayer();
        }

        public NotaPedidoModel saveNotaPedido(NotaPedidoModel notaPedidoModel)
        {
            if(notaPedidoModel.Id == 0) 
                //_dataAccessLayer.InsertNotaPedido
            else
                //_dataAccessLayer.UpdateNotaPedido
        }
    }
}
