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
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The linking_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LinkingMode is required")]
    public required TerraformProperty<string> LinkingMode
    {
        get => GetProperty<TerraformProperty<string>>("linking_mode");
        set => this.WithProperty("linking_mode", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The specified_regions attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SpecifiedRegions
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("specified_regions");
        set => this.WithProperty("specified_regions", value);
    }

}
