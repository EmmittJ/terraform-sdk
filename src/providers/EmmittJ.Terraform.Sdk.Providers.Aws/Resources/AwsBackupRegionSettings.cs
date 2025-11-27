using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_backup_region_settings Terraform resource.
/// Manages a aws_backup_region_settings resource.
/// </summary>
public partial class AwsBackupRegionSettings(string name) : TerraformResource("aws_backup_region_settings", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    /// The resource_type_management_preference attribute.
    /// </summary>
    public TerraformMap<bool> ResourceTypeManagementPreference
    {
        get => TerraformMap<bool>.Lazy(ctx => new TerraformReference<TerraformMap<bool>>(this, "resource_type_management_preference").ResolveNodes(ctx));
        set => SetArgument("resource_type_management_preference", value);
    }

    /// <summary>
    /// The resource_type_opt_in_preference attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceTypeOptInPreference is required")]
    public required TerraformMap<bool> ResourceTypeOptInPreference
    {
        get => TerraformMap<bool>.Lazy(ctx => new TerraformReference<TerraformMap<bool>>(this, "resource_type_opt_in_preference").ResolveNodes(ctx));
        set => SetArgument("resource_type_opt_in_preference", value);
    }

}
