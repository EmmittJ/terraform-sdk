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
        SetOutput("arn");
        SetOutput("deployment_duration_in_minutes");
        SetOutput("description");
        SetOutput("final_bake_time_in_minutes");
        SetOutput("growth_factor");
        SetOutput("growth_type");
        SetOutput("id");
        SetOutput("name");
        SetOutput("region");
        SetOutput("replicate_to");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The deployment_duration_in_minutes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeploymentDurationInMinutes is required")]
    public required TerraformProperty<double> DeploymentDurationInMinutes
    {
        get => GetRequiredOutput<TerraformProperty<double>>("deployment_duration_in_minutes");
        set => SetProperty("deployment_duration_in_minutes", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The final_bake_time_in_minutes attribute.
    /// </summary>
    public TerraformProperty<double> FinalBakeTimeInMinutes
    {
        get => GetRequiredOutput<TerraformProperty<double>>("final_bake_time_in_minutes");
        set => SetProperty("final_bake_time_in_minutes", value);
    }

    /// <summary>
    /// The growth_factor attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GrowthFactor is required")]
    public required TerraformProperty<double> GrowthFactor
    {
        get => GetRequiredOutput<TerraformProperty<double>>("growth_factor");
        set => SetProperty("growth_factor", value);
    }

    /// <summary>
    /// The growth_type attribute.
    /// </summary>
    public TerraformProperty<string> GrowthType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("growth_type");
        set => SetProperty("growth_type", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// The replicate_to attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicateTo is required")]
    public required TerraformProperty<string> ReplicateTo
    {
        get => GetRequiredOutput<TerraformProperty<string>>("replicate_to");
        set => SetProperty("replicate_to", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
