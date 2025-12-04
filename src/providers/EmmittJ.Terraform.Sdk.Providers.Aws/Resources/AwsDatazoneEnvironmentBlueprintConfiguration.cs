using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_datazone_environment_blueprint_configuration Terraform resource.
/// Manages a aws_datazone_environment_blueprint_configuration resource.
/// </summary>
public partial class AwsDatazoneEnvironmentBlueprintConfiguration(string name) : TerraformResource("aws_datazone_environment_blueprint_configuration", name)
{
    /// <summary>
    /// The domain_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainId is required")]
    public required TerraformValue<string> DomainId
    {
        get => GetArgument<TerraformValue<string>>("domain_id");
        set => SetArgument("domain_id", value);
    }

    /// <summary>
    /// The enabled_regions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnabledRegions is required")]
    public TerraformList<string>? EnabledRegions
    {
        get => GetArgument<TerraformList<string>>("enabled_regions");
        set => SetArgument("enabled_regions", value);
    }

    /// <summary>
    /// The environment_blueprint_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnvironmentBlueprintId is required")]
    public required TerraformValue<string> EnvironmentBlueprintId
    {
        get => GetArgument<TerraformValue<string>>("environment_blueprint_id");
        set => SetArgument("environment_blueprint_id", value);
    }

    /// <summary>
    /// The manage_access_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? ManageAccessRoleArn
    {
        get => GetArgument<TerraformValue<string>>("manage_access_role_arn");
        set => SetArgument("manage_access_role_arn", value);
    }

    /// <summary>
    /// The provisioning_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? ProvisioningRoleArn
    {
        get => GetArgument<TerraformValue<string>>("provisioning_role_arn");
        set => SetArgument("provisioning_role_arn", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The regional_parameters attribute.
    /// </summary>
    public TerraformMap<TerraformMap<string>>? RegionalParameters
    {
        get => GetArgument<TerraformMap<TerraformMap<string>>>("regional_parameters");
        set => SetArgument("regional_parameters", value);
    }

}
