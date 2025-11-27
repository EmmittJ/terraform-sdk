using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_lambda_layer_version_permission Terraform resource.
/// Manages a aws_lambda_layer_version_permission resource.
/// </summary>
public partial class AwsLambdaLayerVersionPermission(string name) : TerraformResource("aws_lambda_layer_version_permission", name)
{
    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformValue<string> Action
    {
        get => new TerraformReference<string>(this, "action");
        set => SetArgument("action", value);
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
    /// The layer_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LayerName is required")]
    public required TerraformValue<string> LayerName
    {
        get => new TerraformReference<string>(this, "layer_name");
        set => SetArgument("layer_name", value);
    }

    /// <summary>
    /// The organization_id attribute.
    /// </summary>
    public TerraformValue<string>? OrganizationId
    {
        get => new TerraformReference<string>(this, "organization_id");
        set => SetArgument("organization_id", value);
    }

    /// <summary>
    /// The principal attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Principal is required")]
    public required TerraformValue<string> Principal
    {
        get => new TerraformReference<string>(this, "principal");
        set => SetArgument("principal", value);
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
    /// The skip_destroy attribute.
    /// </summary>
    public TerraformValue<bool>? SkipDestroy
    {
        get => new TerraformReference<bool>(this, "skip_destroy");
        set => SetArgument("skip_destroy", value);
    }

    /// <summary>
    /// The statement_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StatementId is required")]
    public required TerraformValue<string> StatementId
    {
        get => new TerraformReference<string>(this, "statement_id");
        set => SetArgument("statement_id", value);
    }

    /// <summary>
    /// The version_number attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VersionNumber is required")]
    public required TerraformValue<double> VersionNumber
    {
        get => new TerraformReference<double>(this, "version_number");
        set => SetArgument("version_number", value);
    }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    public TerraformValue<string> Policy
    {
        get => new TerraformReference<string>(this, "policy");
    }

    /// <summary>
    /// The revision_id attribute.
    /// </summary>
    public TerraformValue<string> RevisionId
    {
        get => new TerraformReference<string>(this, "revision_id");
    }

}
