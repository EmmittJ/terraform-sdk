using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsDatazoneEnvironment.
/// Nesting mode: single
/// </summary>
public class AwsDatazoneEnvironmentTimeoutsBlock : TerraformBlock
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
/// Block type for user_parameters in AwsDatazoneEnvironment.
/// Nesting mode: list
/// </summary>
public class AwsDatazoneEnvironmentUserParametersBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Represents a aws_datazone_environment Terraform resource.
/// Manages a aws_datazone_environment resource.
/// </summary>
public partial class AwsDatazoneEnvironment(string name) : TerraformResource("aws_datazone_environment", name)
{
    /// <summary>
    /// The account_identifier attribute.
    /// </summary>
    public TerraformValue<string> AccountIdentifier
    {
        get => new TerraformReference<string>(this, "account_identifier");
        set => SetArgument("account_identifier", value);
    }

    /// <summary>
    /// The account_region attribute.
    /// </summary>
    public TerraformValue<string> AccountRegion
    {
        get => new TerraformReference<string>(this, "account_region");
        set => SetArgument("account_region", value);
    }

    /// <summary>
    /// The blueprint_identifier attribute.
    /// </summary>
    public TerraformValue<string> BlueprintIdentifier
    {
        get => new TerraformReference<string>(this, "blueprint_identifier");
        set => SetArgument("blueprint_identifier", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The domain_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainIdentifier is required")]
    public required TerraformValue<string> DomainIdentifier
    {
        get => new TerraformReference<string>(this, "domain_identifier");
        set => SetArgument("domain_identifier", value);
    }

    /// <summary>
    /// The glossary_terms attribute.
    /// </summary>
    public TerraformList<string>? GlossaryTerms
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "glossary_terms").ResolveNodes(ctx));
        set => SetArgument("glossary_terms", value);
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
    /// The profile_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProfileIdentifier is required")]
    public required TerraformValue<string> ProfileIdentifier
    {
        get => new TerraformReference<string>(this, "profile_identifier");
        set => SetArgument("profile_identifier", value);
    }

    /// <summary>
    /// The project_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectIdentifier is required")]
    public required TerraformValue<string> ProjectIdentifier
    {
        get => new TerraformReference<string>(this, "project_identifier");
        set => SetArgument("project_identifier", value);
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
    /// The created_at attribute.
    /// </summary>
    public TerraformValue<string> CreatedAt
    {
        get => new TerraformReference<string>(this, "created_at");
    }

    /// <summary>
    /// The created_by attribute.
    /// </summary>
    public TerraformValue<string> CreatedBy
    {
        get => new TerraformReference<string>(this, "created_by");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The last_deployment attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> LastDeployment
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "last_deployment").ResolveNodes(ctx));
    }

    /// <summary>
    /// The provider_environment attribute.
    /// </summary>
    public TerraformValue<string> ProviderEnvironment
    {
        get => new TerraformReference<string>(this, "provider_environment");
    }

    /// <summary>
    /// The provisioned_resources attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ProvisionedResources
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "provisioned_resources").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsDatazoneEnvironmentTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsDatazoneEnvironmentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// UserParameters block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsDatazoneEnvironmentUserParametersBlock>? UserParameters
    {
        get => GetArgument<TerraformList<AwsDatazoneEnvironmentUserParametersBlock>>("user_parameters");
        set => SetArgument("user_parameters", value);
    }

}
