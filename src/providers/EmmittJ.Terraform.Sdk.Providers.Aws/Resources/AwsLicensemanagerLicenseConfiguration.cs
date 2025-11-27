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
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The license_count attribute.
    /// </summary>
    public TerraformValue<double>? LicenseCount
    {
        get => new TerraformReference<double>(this, "license_count");
        set => SetArgument("license_count", value);
    }

    /// <summary>
    /// The license_count_hard_limit attribute.
    /// </summary>
    public TerraformValue<bool>? LicenseCountHardLimit
    {
        get => new TerraformReference<bool>(this, "license_count_hard_limit");
        set => SetArgument("license_count_hard_limit", value);
    }

    /// <summary>
    /// The license_counting_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LicenseCountingType is required")]
    public required TerraformValue<string> LicenseCountingType
    {
        get => new TerraformReference<string>(this, "license_counting_type");
        set => SetArgument("license_counting_type", value);
    }

    /// <summary>
    /// The license_rules attribute.
    /// </summary>
    public TerraformList<string>? LicenseRules
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "license_rules").ResolveNodes(ctx));
        set => SetArgument("license_rules", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The owner_account_id attribute.
    /// </summary>
    public TerraformValue<string> OwnerAccountId
    {
        get => new TerraformReference<string>(this, "owner_account_id");
    }

}
