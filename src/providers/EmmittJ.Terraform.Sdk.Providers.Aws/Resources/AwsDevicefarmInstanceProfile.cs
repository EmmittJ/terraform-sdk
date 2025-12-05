using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_devicefarm_instance_profile Terraform resource.
/// Manages a aws_devicefarm_instance_profile resource.
/// </summary>
public partial class AwsDevicefarmInstanceProfile(string name) : TerraformResource("aws_devicefarm_instance_profile", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The exclude_app_packages_from_cleanup attribute.
    /// </summary>
    public TerraformSet<string>? ExcludeAppPackagesFromCleanup
    {
        get => GetArgument<TerraformSet<string>>("exclude_app_packages_from_cleanup");
        set => SetArgument("exclude_app_packages_from_cleanup", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The package_cleanup attribute.
    /// </summary>
    public TerraformValue<bool>? PackageCleanup
    {
        get => GetArgument<TerraformValue<bool>>("package_cleanup");
        set => SetArgument("package_cleanup", value);
    }

    /// <summary>
    /// The reboot_after_use attribute.
    /// </summary>
    public TerraformValue<bool>? RebootAfterUse
    {
        get => GetArgument<TerraformValue<bool>>("reboot_after_use");
        set => SetArgument("reboot_after_use", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? CreateReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

}
