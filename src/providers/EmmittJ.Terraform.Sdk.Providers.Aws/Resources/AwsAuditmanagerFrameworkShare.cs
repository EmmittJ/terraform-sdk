using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_auditmanager_framework_share Terraform resource.
/// Manages a aws_auditmanager_framework_share resource.
/// </summary>
public partial class AwsAuditmanagerFrameworkShare(string name) : TerraformResource("aws_auditmanager_framework_share", name)
{
    /// <summary>
    /// The comment attribute.
    /// </summary>
    public TerraformValue<string>? Comment
    {
        get => new TerraformReference<string>(this, "comment");
        set => SetArgument("comment", value);
    }

    /// <summary>
    /// The destination_account attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationAccount is required")]
    public required TerraformValue<string> DestinationAccount
    {
        get => new TerraformReference<string>(this, "destination_account");
        set => SetArgument("destination_account", value);
    }

    /// <summary>
    /// The destination_region attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationRegion is required")]
    public required TerraformValue<string> DestinationRegion
    {
        get => new TerraformReference<string>(this, "destination_region");
        set => SetArgument("destination_region", value);
    }

    /// <summary>
    /// The framework_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrameworkId is required")]
    public required TerraformValue<string> FrameworkId
    {
        get => new TerraformReference<string>(this, "framework_id");
        set => SetArgument("framework_id", value);
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
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

}
