using System;


namespace TryCatchExercise.Entities.Execptions
{
    internal class DomainExecption : ApplicationException
    {
        public DomainExecption(string message) : base(message) { }
    }
}
