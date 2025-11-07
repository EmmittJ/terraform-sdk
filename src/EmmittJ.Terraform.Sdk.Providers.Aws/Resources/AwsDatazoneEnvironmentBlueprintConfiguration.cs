using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_datazone_environment_blueprint_configuration resource.
/// </summary>
public class AwsDatazoneEnvironmentBlueprintConfiguration : TerraformResource
{
    public AwsDatazoneEnvironmentBlueprintConfiguration(string name) : base("aws_datazone_environment_blueprint_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The domain_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DomainId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain_id");
        set => this.WithProperty("domain_id", value);
    }

    /// <summary>
    /// The enabled_regions attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? EnabledRegions
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("enabled_regions");
        set => this.WithProperty("enabled_regions", value);
    }

    /// <summary>
    /// The environment_blueprint_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EnvironmentBlueprintId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("environment_blueprint_id");
        set => this.WithProperty("environment_blueprint_id", value);
    }

    /// <summary>
    /// The manage_access_role_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ManageAccessRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("manage_access_role_arn");
        set => this.WithProperty("manage_access_role_arn", value);
    }

    /// <summary>
    /// The provisioning_role_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ProvisioningRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("provisioning_role_arn");
        set => this.WithProperty("provisioning_role_arn", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The regional_parameters attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, Dictionary<string, string>>>? RegionalParameters
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, Dictionary<string, string>>>>("regional_parameters");
        set => this.WithProperty("regional_parameters", value);
    }

}
