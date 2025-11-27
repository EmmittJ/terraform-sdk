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
        get => new TerraformReference<string>(this, "domain_id");
        set => SetArgument("domain_id", value);
    }

    /// <summary>
    /// The enabled_regions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnabledRegions is required")]
    public TerraformList<string>? EnabledRegions
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "enabled_regions").ResolveNodes(ctx));
        set => SetArgument("enabled_regions", value);
    }

    /// <summary>
    /// The environment_blueprint_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnvironmentBlueprintId is required")]
    public required TerraformValue<string> EnvironmentBlueprintId
    {
        get => new TerraformReference<string>(this, "environment_blueprint_id");
        set => SetArgument("environment_blueprint_id", value);
    }

    /// <summary>
    /// The manage_access_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? ManageAccessRoleArn
    {
        get => new TerraformReference<string>(this, "manage_access_role_arn");
        set => SetArgument("manage_access_role_arn", value);
    }

    /// <summary>
    /// The provisioning_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? ProvisioningRoleArn
    {
        get => new TerraformReference<string>(this, "provisioning_role_arn");
        set => SetArgument("provisioning_role_arn", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The regional_parameters attribute.
    /// </summary>
    public TerraformMap<TerraformMap<string>>? RegionalParameters
    {
        get => TerraformMap<TerraformMap<string>>.Lazy(ctx => new TerraformReference<TerraformMap<TerraformMap<string>>>(this, "regional_parameters").ResolveNodes(ctx));
        set => SetArgument("regional_parameters", value);
    }

}
