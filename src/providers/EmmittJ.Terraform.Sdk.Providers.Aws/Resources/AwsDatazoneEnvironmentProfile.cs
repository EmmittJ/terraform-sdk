using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for user_parameters in AwsDatazoneEnvironmentProfile.
/// Nesting mode: list
/// </summary>
public class AwsDatazoneEnvironmentProfileUserParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "user_parameters";

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Represents a aws_datazone_environment_profile Terraform resource.
/// Manages a aws_datazone_environment_profile resource.
/// </summary>
public partial class AwsDatazoneEnvironmentProfile(string name) : TerraformResource("aws_datazone_environment_profile", name)
{
    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    public TerraformValue<string>? AwsAccountId
    {
        get => GetArgument<TerraformValue<string>>("aws_account_id");
        set => SetArgument("aws_account_id", value);
    }

    /// <summary>
    /// The aws_account_region attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AwsAccountRegion is required")]
    public required TerraformValue<string> AwsAccountRegion
    {
        get => GetArgument<TerraformValue<string>>("aws_account_region");
        set => SetArgument("aws_account_region", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The domain_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainIdentifier is required")]
    public required TerraformValue<string> DomainIdentifier
    {
        get => GetArgument<TerraformValue<string>>("domain_identifier");
        set => SetArgument("domain_identifier", value);
    }

    /// <summary>
    /// The environment_blueprint_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnvironmentBlueprintIdentifier is required")]
    public required TerraformValue<string> EnvironmentBlueprintIdentifier
    {
        get => GetArgument<TerraformValue<string>>("environment_blueprint_identifier");
        set => SetArgument("environment_blueprint_identifier", value);
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
    /// The project_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectIdentifier is required")]
    public required TerraformValue<string> ProjectIdentifier
    {
        get => GetArgument<TerraformValue<string>>("project_identifier");
        set => SetArgument("project_identifier", value);
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
    /// The created_at attribute.
    /// </summary>
    public TerraformValue<string> CreatedAt
        => AsReference("created_at");

    /// <summary>
    /// The created_by attribute.
    /// </summary>
    public TerraformValue<string> CreatedBy
        => AsReference("created_by");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The updated_at attribute.
    /// </summary>
    public TerraformValue<string> UpdatedAt
        => AsReference("updated_at");

    /// <summary>
    /// UserParameters block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsDatazoneEnvironmentProfileUserParametersBlock>? UserParameters
    {
        get => GetArgument<TerraformList<AwsDatazoneEnvironmentProfileUserParametersBlock>>("user_parameters");
        set => SetArgument("user_parameters", value);
    }

}
