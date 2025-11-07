using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_codecatalyst_dev_environment resource.
/// </summary>
public class AwsCodecatalystDevEnvironment : TerraformResource
{
    public AwsCodecatalystDevEnvironment(string name) : base("aws_codecatalyst_dev_environment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The alias attribute.
    /// </summary>
    public TerraformProperty<string>? Alias
    {
        get => GetProperty<TerraformProperty<string>>("alias");
        set => this.WithProperty("alias", value);
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
    /// The inactivity_timeout_minutes attribute.
    /// </summary>
    public TerraformProperty<double>? InactivityTimeoutMinutes
    {
        get => GetProperty<TerraformProperty<double>>("inactivity_timeout_minutes");
        set => this.WithProperty("inactivity_timeout_minutes", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public TerraformProperty<string>? InstanceType
    {
        get => GetProperty<TerraformProperty<string>>("instance_type");
        set => this.WithProperty("instance_type", value);
    }

    /// <summary>
    /// The project_name attribute.
    /// </summary>
    public TerraformProperty<string>? ProjectName
    {
        get => GetProperty<TerraformProperty<string>>("project_name");
        set => this.WithProperty("project_name", value);
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
    /// The space_name attribute.
    /// </summary>
    public TerraformProperty<string>? SpaceName
    {
        get => GetProperty<TerraformProperty<string>>("space_name");
        set => this.WithProperty("space_name", value);
    }

}
