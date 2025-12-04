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
        get => GetRequiredArgument<TerraformValue<string>>("control_status");
        set => SetArgument("control_status", value);
    }

    /// <summary>
    /// The disabled_reason attribute.
    /// </summary>
    public TerraformValue<string> DisabledReason
    {
        get => GetArgument<TerraformValue<string>>("disabled_reason") ?? AsReference("disabled_reason");
        set => SetArgument("disabled_reason", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The standards_control_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StandardsControlArn is required")]
    public required TerraformValue<string> StandardsControlArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("standards_control_arn");
        set => SetArgument("standards_control_arn", value);
    }

    /// <summary>
    /// The control_id attribute.
    /// </summary>
    public TerraformValue<string> ControlId
        => AsReference("control_id");

    /// <summary>
    /// The control_status_updated_at attribute.
    /// </summary>
    public TerraformValue<string> ControlStatusUpdatedAt
        => AsReference("control_status_updated_at");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The related_requirements attribute.
    /// </summary>
    public TerraformList<string> RelatedRequirements
        => AsReference("related_requirements");

    /// <summary>
    /// The remediation_url attribute.
    /// </summary>
    public TerraformValue<string> RemediationUrl
        => AsReference("remediation_url");

    /// <summary>
    /// The severity_rating attribute.
    /// </summary>
    public TerraformValue<string> SeverityRating
        => AsReference("severity_rating");

    /// <summary>
    /// The title attribute.
    /// </summary>
    public TerraformValue<string> Title
        => AsReference("title");

}
