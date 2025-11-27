using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_securityhub_standards_control Terraform resource.
/// Manages a aws_securityhub_standards_control resource.
/// </summary>
public partial class AwsSecurityhubStandardsControl(string name) : TerraformResource("aws_securityhub_standards_control", name)
{
    /// <summary>
    /// The control_status attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ControlStatus is required")]
    public required TerraformValue<string> ControlStatus
    {
        get => new TerraformReference<string>(this, "control_status");
        set => SetArgument("control_status", value);
    }

    /// <summary>
    /// The disabled_reason attribute.
    /// </summary>
    public TerraformValue<string> DisabledReason
    {
        get => new TerraformReference<string>(this, "disabled_reason");
        set => SetArgument("disabled_reason", value);
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
    /// The standards_control_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StandardsControlArn is required")]
    public required TerraformValue<string> StandardsControlArn
    {
        get => new TerraformReference<string>(this, "standards_control_arn");
        set => SetArgument("standards_control_arn", value);
    }

    /// <summary>
    /// The control_id attribute.
    /// </summary>
    public TerraformValue<string> ControlId
    {
        get => new TerraformReference<string>(this, "control_id");
    }

    /// <summary>
    /// The control_status_updated_at attribute.
    /// </summary>
    public TerraformValue<string> ControlStatusUpdatedAt
    {
        get => new TerraformReference<string>(this, "control_status_updated_at");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The related_requirements attribute.
    /// </summary>
    public TerraformList<string> RelatedRequirements
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "related_requirements").ResolveNodes(ctx));
    }

    /// <summary>
    /// The remediation_url attribute.
    /// </summary>
    public TerraformValue<string> RemediationUrl
    {
        get => new TerraformReference<string>(this, "remediation_url");
    }

    /// <summary>
    /// The severity_rating attribute.
    /// </summary>
    public TerraformValue<string> SeverityRating
    {
        get => new TerraformReference<string>(this, "severity_rating");
    }

    /// <summary>
    /// The title attribute.
    /// </summary>
    public TerraformValue<string> Title
    {
        get => new TerraformReference<string>(this, "title");
    }

}
