using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_securityhub_account Terraform resource.
/// Manages a aws_securityhub_account resource.
/// </summary>
public partial class AwsSecurityhubAccount(string name) : TerraformResource("aws_securityhub_account", name)
{
    /// <summary>
    /// The auto_enable_controls attribute.
    /// </summary>
    public TerraformValue<bool>? AutoEnableControls
    {
        get => new TerraformReference<bool>(this, "auto_enable_controls");
        set => SetArgument("auto_enable_controls", value);
    }

    /// <summary>
    /// The control_finding_generator attribute.
    /// </summary>
    public TerraformValue<string> ControlFindingGenerator
    {
        get => new TerraformReference<string>(this, "control_finding_generator");
        set => SetArgument("control_finding_generator", value);
    }

    /// <summary>
    /// The enable_default_standards attribute.
    /// </summary>
    public TerraformValue<bool>? EnableDefaultStandards
    {
        get => new TerraformReference<bool>(this, "enable_default_standards");
        set => SetArgument("enable_default_standards", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

}
