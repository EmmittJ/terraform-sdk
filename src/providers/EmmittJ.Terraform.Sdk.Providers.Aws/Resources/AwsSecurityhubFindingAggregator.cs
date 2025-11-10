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
        SetOutput("id");
        SetOutput("linking_mode");
        SetOutput("region");
        SetOutput("specified_regions");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The linking_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LinkingMode is required")]
    public required TerraformProperty<string> LinkingMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("linking_mode");
        set => SetProperty("linking_mode", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The specified_regions attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> SpecifiedRegions
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("specified_regions");
        set => SetProperty("specified_regions", value);
    }

}
