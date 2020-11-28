﻿using SmartHub.Messaging.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHub.Messaging.Abstractions
{
  public interface IEventBus
  {
    void Publish(IntegrationEvent @event);

    void Subscribe<T, TH>() where T : IntegrationEvent
                           where TH : IIntegrationEventHandler<T>;


    void Unsubscribe<T, TH>() where T : IntegrationEvent
                            where TH : IIntegrationEventHandler<T>;

  }
}
