﻿using System;
using System.Collections.Generic;

namespace Birthflow_api.Infrastructure.Models;

public partial class FetalHeartRate
{
    public int FetalHeartRateId { get; set; }

    public string? PartographId { get; set; }

    public string Value { get; set; } = null!;

    public DateTime Time { get; set; }

    public virtual Partograph? Partograph { get; set; }
}
