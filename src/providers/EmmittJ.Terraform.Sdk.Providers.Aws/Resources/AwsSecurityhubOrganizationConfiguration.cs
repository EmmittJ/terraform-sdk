using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for organization_configuration in AwsSecurityhubOrganizationConfiguration.
/// Nesting mode: list
/// </summary>
public class AwsSecurityhubOrganizationConfigurationOrganizationConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "organization_configuration";

    /// <summary>
    /// The configuration_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigurationType is required")]
    public required TerraformValue<string> ConfigurationType
    {
        get => new TerraformReference<string>(this, "configuration_type");
        set => SetArgument("configuration_type", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsSecurityhubOrganizationConfiguration.
/// Nesting mode: single
/// </summary>
public class AwsSecurityhubOrganizationConfigurationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_securityhub_organization_configuration Terraform resource.
/// Manages a aws_securityhub_organization_configuration resource.
/// </summary>
public partial class AwsSecurityhubOrganizationConfiguration(string name) : TerraformResource("aws_securityhub_organization_configuration", name)
{
    /// <summary>
    /// The auto_enable attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoEnable is required")]
    public required TerraformValue<bool> AutoEnable
    {
        get => new TerraformReference<bool>(this, "auto_enable");
        set => SetArgument("auto_enable", value);
    }

    /// <summary>
    /// The auto_enable_standards attribute.
    /// </summary>
    public TerraformValue<string> AutoEnableStandards
    {
        get => new TerraformReference<string>(this, "auto_enable_standards");
        set => SetArgument("auto_enable_standards", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// OrganizationConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OrganizationConfiguration block(s) allowed")]
    public TerraformList<AwsSecurityhubOrganizationConfigurationOrganizationConfigurationBlock>? OrganizationConfiguration
    {
        get => GetArgument<TerraformList<AwsSecurityhubOrganizationConfigurationOrganizationConfigurationBlock>>("organization_configuration");
        set => SetArgument("organization_configuration", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsSecurityhubOrganizationConfigurationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsSecurityhubOrganizationConfigurationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
