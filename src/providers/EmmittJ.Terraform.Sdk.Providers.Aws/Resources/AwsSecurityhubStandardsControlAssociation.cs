using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_securityhub_standards_control_association Terraform resource.
/// Manages a aws_securityhub_standards_control_association resource.
/// </summary>
public partial class AwsSecurityhubStandardsControlAssociation(string name) : TerraformResource("aws_securityhub_standards_control_association", name)
{
    /// <summary>
    /// The association_status attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AssociationStatus is required")]
    public required TerraformValue<string> AssociationStatus
    {
        get => GetArgument<TerraformValue<string>>("association_status");
        set => SetArgument("association_status", value);
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
    /// The security_control_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityControlId is required")]
    public required TerraformValue<string> SecurityControlId
    {
        get => GetArgument<TerraformValue<string>>("security_control_id");
        set => SetArgument("security_control_id", value);
    }

    /// <summary>
    /// The standards_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StandardsArn is required")]
    public required TerraformValue<string> StandardsArn
    {
        get => GetArgument<TerraformValue<string>>("standards_arn");
        set => SetArgument("standards_arn", value);
    }

    /// <summary>
    /// The updated_reason attribute.
    /// </summary>
    public TerraformValue<string>? UpdatedReason
    {
        get => GetArgument<TerraformValue<string>>("updated_reason");
        set => SetArgument("updated_reason", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

}
