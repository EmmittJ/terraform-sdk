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
    public string? Alias
    {
        get => GetProperty<TerraformLiteralProperty<string>>("alias")?.Value;
        set => this.WithProperty("alias", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The inactivity_timeout_minutes attribute.
    /// </summary>
    public double? InactivityTimeoutMinutes
    {
        get => GetProperty<TerraformLiteralProperty<double>>("inactivity_timeout_minutes")?.Value;
        set => this.WithProperty("inactivity_timeout_minutes", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public string? InstanceType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance_type")?.Value;
        set => this.WithProperty("instance_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project_name attribute.
    /// </summary>
    public string? ProjectName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project_name")?.Value;
        set => this.WithProperty("project_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The space_name attribute.
    /// </summary>
    public string? SpaceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("space_name")?.Value;
        set => this.WithProperty("space_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
