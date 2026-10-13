using System.Collections.Generic;
using BIMQualityChecker.Core.Models;

namespace BIMQualityChecker.Core.Rules
{
    public interface IRule
    {
        string Id { get; }
        string Name { get; }
        string Description { get; }
        Severity Severity { get; }
        string Category { get; }
        RuleResult Evaluate(IReadOnlyList<ElementInfo> elements);
    }
}
