using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class IPhoneBuilder : ICelular
    {
        Celular celular;

        public Celular Celular
        {
            get { return this.celular; }
        }

        public IPhoneBuilder()
        {
            celular = new Celular("Iphone");
        }


        public void BuildBateria()
        {
            this.celular.bateria = "MAH_1500";
        }

        public void BuildCamera()
        {
            this.celular.camera = "16 MP";
        }

        public void BuildSistema()
        {
            this.celular.sistema = "iOS 11";
        }

        public void BuildTela()
        {
            this.celular.tela = "7";
        }

    }
}