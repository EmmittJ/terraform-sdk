using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cloudformation_stack_set resource.
/// </summary>
public class AwsCloudformationStackSet : TerraformResource
{
    public AwsCloudformationStackSet(string name) : base("aws_cloudformation_stack_set", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("stack_set_id");
    }

    /// <summary>
    /// The administration_role_arn attribute.
    /// </summary>
    public string? AdministrationRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("administration_role_arn")?.Value;
        set => this.WithProperty("administration_role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The call_as attribute.
    /// </summary>
    public string? CallAs
    {
        get => GetProperty<TerraformLiteralProperty<string>>("call_as")?.Value;
        set => this.WithProperty("call_as", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The capabilities attribute.
    /// </summary>
    public HashSet<string>? Capabilities
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("capabilities")?.Value;
        set => this.WithProperty("capabilities", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The execution_role_name attribute.
    /// </summary>
    public string? ExecutionRoleName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("execution_role_name")?.Value;
        set => this.WithProperty("execution_role_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public Dictionary<string, string>? Parameters
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("parameters")?.Value;
        set => this.WithProperty("parameters", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The permission_model attribute.
    /// </summary>
    public string? PermissionModel
    {
        get => GetProperty<TerraformLiteralProperty<string>>("permission_model")?.Value;
        set => this.WithProperty("permission_model", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The template_body attribute.
    /// </summary>
    public string? TemplateBody
    {
        get => GetProperty<TerraformLiteralProperty<string>>("template_body")?.Value;
        set => this.WithProperty("template_body", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The template_url attribute.
    /// </summary>
    public string? TemplateUrl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("template_url")?.Value;
        set => this.WithProperty("template_url", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The stack_set_id attribute.
    /// </summary>
    public TerraformExpression StackSetId => this["stack_set_id"];

}
