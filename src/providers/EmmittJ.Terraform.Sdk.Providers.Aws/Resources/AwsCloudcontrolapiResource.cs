using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsCloudcontrolapiResource.
/// Nesting mode: single
/// </summary>
public class AwsCloudcontrolapiResourceTimeoutsBlock : TerraformBlock
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
/// Represents a aws_cloudcontrolapi_resource Terraform resource.
/// Manages a aws_cloudcontrolapi_resource resource.
/// </summary>
public partial class AwsCloudcontrolapiResource(string name) : TerraformResource("aws_cloudcontrolapi_resource", name)
{
    /// <summary>
    /// The desired_state attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DesiredState is required")]
    public required TerraformValue<string> DesiredState
    {
        get => new TerraformReference<string>(this, "desired_state");
        set => SetArgument("desired_state", value);
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
    /// The role_arn attribute.
    /// </summary>
    public TerraformValue<string>? RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The schema attribute.
    /// </summary>
    public TerraformValue<string> Schema
    {
        get => new TerraformReference<string>(this, "schema");
        set => SetArgument("schema", value);
    }

    /// <summary>
    /// The type_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TypeName is required")]
    public required TerraformValue<string> TypeName
    {
        get => new TerraformReference<string>(this, "type_name");
        set => SetArgument("type_name", value);
    }

    /// <summary>
    /// The type_version_id attribute.
    /// </summary>
    public TerraformValue<string>? TypeVersionId
    {
        get => new TerraformReference<string>(this, "type_version_id");
        set => SetArgument("type_version_id", value);
    }

    /// <summary>
    /// The properties attribute.
    /// </summary>
    public TerraformValue<string> Properties
    {
        get => new TerraformReference<string>(this, "properties");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsCloudcontrolapiResourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsCloudcontrolapiResourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
