using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_auditmanager_framework Terraform data source.
/// Retrieves information about a aws_auditmanager_framework.
/// </summary>
public partial class AwsAuditmanagerFrameworkDataSource(string name) : TerraformDataSource("aws_auditmanager_framework", name)
{
    /// <summary>
    /// The framework_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrameworkType is required")]
    public required TerraformValue<string> FrameworkType
    {
        get => GetArgument<TerraformValue<string>>("framework_type");
        set => SetArgument("framework_type", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The compliance_type attribute.
    /// </summary>
    public TerraformValue<string> ComplianceType
        => AsReference("compliance_type");

    /// <summary>
    /// The control_sets attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ControlSets
        => AsReference("control_sets");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

}
