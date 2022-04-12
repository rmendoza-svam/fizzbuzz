namespace Fizz_Buzz.infrastructure.handlers
{
    public abstract class Handler<T> : IHandler<T> where T : class
    {
        private IHandler<T>  Next { get; set; }

        public virtual void Handle(T request)
        {
            Next?.Handle(request);
        }

        public IHandler<T> SetNext(IHandler<T> handler)
        {
            this.Next = handler;
            return Next;
        }
    }
    public interface IHandler<T> where T : class
    {
        IHandler<T> SetNext(IHandler<T> handler);
        void Handle(T request);
    }
}
