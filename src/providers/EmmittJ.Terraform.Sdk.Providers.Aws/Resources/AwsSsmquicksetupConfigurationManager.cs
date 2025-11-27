using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for configuration_definition in AwsSsmquicksetupConfigurationManager.
/// Nesting mode: list
/// </summary>
public class AwsSsmquicksetupConfigurationManagerConfigurationDefinitionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "configuration_definition";

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The local_deployment_administration_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? LocalDeploymentAdministrationRoleArn
    {
        get => new TerraformReference<string>(this, "local_deployment_administration_role_arn");
        set => SetArgument("local_deployment_administration_role_arn", value);
    }

    /// <summary>
    /// The local_deployment_execution_role_name attribute.
    /// </summary>
    public TerraformValue<string>? LocalDeploymentExecutionRoleName
    {
        get => new TerraformReference<string>(this, "local_deployment_execution_role_name");
        set => SetArgument("local_deployment_execution_role_name", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parameters is required")]
    public required TerraformMap<string> Parameters
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "parameters").ResolveNodes(ctx));
        set => SetArgument("parameters", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The type_version attribute.
    /// </summary>
    public TerraformValue<string> TypeVersion
    {
        get => new TerraformReference<string>(this, "type_version");
        set => SetArgument("type_version", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsSsmquicksetupConfigurationManager.
/// Nesting mode: single
/// </summary>
public class AwsSsmquicksetupConfigurationManagerTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_ssmquicksetup_configuration_manager Terraform resource.
/// Manages a aws_ssmquicksetup_configuration_manager resource.
/// </summary>
public partial class AwsSsmquicksetupConfigurationManager(string name) : TerraformResource("aws_ssmquicksetup_configuration_manager", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The manager_arn attribute.
    /// </summary>
    public TerraformValue<string> ManagerArn
    {
        get => new TerraformReference<string>(this, "manager_arn");
    }

    /// <summary>
    /// The status_summaries attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> StatusSummaries
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "status_summaries").ResolveNodes(ctx));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
    }

    /// <summary>
    /// ConfigurationDefinition block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsSsmquicksetupConfigurationManagerConfigurationDefinitionBlock>? ConfigurationDefinition
    {
        get => GetArgument<TerraformList<AwsSsmquicksetupConfigurationManagerConfigurationDefinitionBlock>>("configuration_definition");
        set => SetArgument("configuration_definition", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsSsmquicksetupConfigurationManagerTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsSsmquicksetupConfigurationManagerTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
