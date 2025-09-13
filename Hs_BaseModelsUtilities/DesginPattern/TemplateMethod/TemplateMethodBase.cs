namespace Hs_BaseModelsUtilities.DesginPattern.TemplateMethod
{


    public abstract class TemplateMethodBase
    {
        public void ExecuteTemplate()
        {
            Step1();
            Step2();
            Step3();
        }
        protected abstract void Step1();
        protected abstract void Step2();
        protected virtual void Step3() { }
    }


}
