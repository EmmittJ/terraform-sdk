using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_config_retention_configuration resource.
/// </summary>
public class AwsConfigRetentionConfiguration : TerraformResource
{
    public AwsConfigRetentionConfiguration(string name) : base("aws_config_retention_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("id");
        this.DeclareOutput("name");
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
    /// The retention_period_in_days attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionPeriodInDays is required")]
    public required TerraformProperty<double> RetentionPeriodInDays
    {
        get => GetProperty<TerraformProperty<double>>("retention_period_in_days");
        set => this.WithProperty("retention_period_in_days", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
