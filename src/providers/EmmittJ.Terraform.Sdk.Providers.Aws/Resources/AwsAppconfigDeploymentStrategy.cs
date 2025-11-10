using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_appconfig_deployment_strategy resource.
/// </summary>
public class AwsAppconfigDeploymentStrategy : TerraformResource
{
    public AwsAppconfigDeploymentStrategy(string name) : base("aws_appconfig_deployment_strategy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
    }

    /// <summary>
    /// The deployment_duration_in_minutes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeploymentDurationInMinutes is required")]
    public required TerraformProperty<double> DeploymentDurationInMinutes
    {
        get => GetRequiredProperty<TerraformProperty<double>>("deployment_duration_in_minutes");
        set => this.WithProperty("deployment_duration_in_minutes", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The final_bake_time_in_minutes attribute.
    /// </summary>
    public TerraformProperty<double>? FinalBakeTimeInMinutes
    {
        get => GetProperty<TerraformProperty<double>>("final_bake_time_in_minutes");
        set => this.WithProperty("final_bake_time_in_minutes", value);
    }

    /// <summary>
    /// The growth_factor attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GrowthFactor is required")]
    public required TerraformProperty<double> GrowthFactor
    {
        get => GetRequiredProperty<TerraformProperty<double>>("growth_factor");
        set => this.WithProperty("growth_factor", value);
    }

    /// <summary>
    /// The growth_type attribute.
    /// </summary>
    public TerraformProperty<string>? GrowthType
    {
        get => GetProperty<TerraformProperty<string>>("growth_type");
        set => this.WithProperty("growth_type", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// The replicate_to attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicateTo is required")]
    public required TerraformProperty<string> ReplicateTo
    {
        get => GetRequiredProperty<TerraformProperty<string>>("replicate_to");
        set => this.WithProperty("replicate_to", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
