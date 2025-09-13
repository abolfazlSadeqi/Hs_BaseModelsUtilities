using System;
using System.Collections.Generic;
using System.Linq;

namespace Hs_BaseModelsUtilities.DesginPattern.Mediator
{
    public class MediatorBase : IMediator
    {
        private readonly Dictionary<Type, List<Delegate>> _handlers = new();
        public void Register<TMessage>(Action<TMessage> handler)
        {
            if (!_handlers.ContainsKey(typeof(TMessage)))
                _handlers[typeof(TMessage)] = new List<Delegate>();
            _handlers[typeof(TMessage)].Add(handler);
        }
        public void Send<TMessage>(TMessage message)
        {
            if (_handlers.TryGetValue(typeof(TMessage), out var handlers))
            {
                foreach (var handler in handlers.Cast<Action<TMessage>>())
                    handler(message);
            }
        }
    }


}
