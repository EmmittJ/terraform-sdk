using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for additional_configuration in AwsGuarddutyOrganizationConfigurationFeature.
/// Nesting mode: list
/// </summary>
public class AwsGuarddutyOrganizationConfigurationFeatureAdditionalConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "additional_configuration";

    /// <summary>
    /// The auto_enable attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoEnable is required")]
    public required TerraformValue<string> AutoEnable
    {
        get => new TerraformReference<string>(this, "auto_enable");
        set => SetArgument("auto_enable", value);
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

}


/// <summary>
/// Represents a aws_guardduty_organization_configuration_feature Terraform resource.
/// Manages a aws_guardduty_organization_configuration_feature resource.
/// </summary>
public partial class AwsGuarddutyOrganizationConfigurationFeature(string name) : TerraformResource("aws_guardduty_organization_configuration_feature", name)
{
    /// <summary>
    /// The auto_enable attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoEnable is required")]
    public required TerraformValue<string> AutoEnable
    {
        get => new TerraformReference<string>(this, "auto_enable");
        set => SetArgument("auto_enable", value);
    }

    /// <summary>
    /// The detector_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DetectorId is required")]
    public required TerraformValue<string> DetectorId
    {
        get => new TerraformReference<string>(this, "detector_id");
        set => SetArgument("detector_id", value);
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
    /// AdditionalConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsGuarddutyOrganizationConfigurationFeatureAdditionalConfigurationBlock>? AdditionalConfiguration
    {
        get => GetArgument<TerraformList<AwsGuarddutyOrganizationConfigurationFeatureAdditionalConfigurationBlock>>("additional_configuration");
        set => SetArgument("additional_configuration", value);
    }

}
