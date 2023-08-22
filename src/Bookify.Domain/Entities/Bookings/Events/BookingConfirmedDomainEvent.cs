﻿using Bookify.Domain.Entities.Abstractions;

namespace Bookify.Domain.Entities.Bookings.Events;

public sealed record BookingConfirmedDomainEvent(Guid bookingId) : IDomainEvent;