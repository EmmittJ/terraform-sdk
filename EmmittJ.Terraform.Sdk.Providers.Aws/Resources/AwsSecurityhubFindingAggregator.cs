using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_securityhub_finding_aggregator resource.
/// </summary>
public class AwsSecurityhubFindingAggregator : TerraformResource
{
    public AwsSecurityhubFindingAggregator(string name) : base("aws_securityhub_finding_aggregator", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The linking_mode attribute.
    /// </summary>
    public string? LinkingMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("linking_mode")?.Value;
        set => this.WithProperty("linking_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The specified_regions attribute.
    /// </summary>
    public HashSet<string>? SpecifiedRegions
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("specified_regions")?.Value;
        set => this.WithProperty("specified_regions", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

}
