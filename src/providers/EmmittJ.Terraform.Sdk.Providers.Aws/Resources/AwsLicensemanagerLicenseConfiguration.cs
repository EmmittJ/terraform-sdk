using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_licensemanager_license_configuration Terraform resource.
/// Manages a aws_licensemanager_license_configuration resource.
/// </summary>
public partial class AwsLicensemanagerLicenseConfiguration(string name) : TerraformResource("aws_licensemanager_license_configuration", name)
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
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The license_count attribute.
    /// </summary>
    public TerraformValue<double>? LicenseCount
    {
        get => GetArgument<TerraformValue<double>>("license_count");
        set => SetArgument("license_count", value);
    }

    /// <summary>
    /// The license_count_hard_limit attribute.
    /// </summary>
    public TerraformValue<bool>? LicenseCountHardLimit
    {
        get => GetArgument<TerraformValue<bool>>("license_count_hard_limit");
        set => SetArgument("license_count_hard_limit", value);
    }

    /// <summary>
    /// The license_counting_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LicenseCountingType is required")]
    public required TerraformValue<string> LicenseCountingType
    {
        get => GetArgument<TerraformValue<string>>("license_counting_type");
        set => SetArgument("license_counting_type", value);
    }

    /// <summary>
    /// The license_rules attribute.
    /// </summary>
    public TerraformList<string>? LicenseRules
    {
        get => GetArgument<TerraformList<string>>("license_rules");
        set => SetArgument("license_rules", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
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
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The owner_account_id attribute.
    /// </summary>
    public TerraformValue<string> OwnerAccountId
        => AsReference("owner_account_id");

}
