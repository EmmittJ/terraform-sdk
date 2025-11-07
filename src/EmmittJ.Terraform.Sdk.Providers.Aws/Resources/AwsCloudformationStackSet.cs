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
    public TerraformProperty<string>? AdministrationRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("administration_role_arn");
        set => this.WithProperty("administration_role_arn", value);
    }

    /// <summary>
    /// The call_as attribute.
    /// </summary>
    public TerraformProperty<string>? CallAs
    {
        get => GetProperty<TerraformProperty<string>>("call_as");
        set => this.WithProperty("call_as", value);
    }

    /// <summary>
    /// The capabilities attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? Capabilities
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("capabilities");
        set => this.WithProperty("capabilities", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The execution_role_name attribute.
    /// </summary>
    public TerraformProperty<string>? ExecutionRoleName
    {
        get => GetProperty<TerraformProperty<string>>("execution_role_name");
        set => this.WithProperty("execution_role_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Parameters
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("parameters");
        set => this.WithProperty("parameters", value);
    }

    /// <summary>
    /// The permission_model attribute.
    /// </summary>
    public TerraformProperty<string>? PermissionModel
    {
        get => GetProperty<TerraformProperty<string>>("permission_model");
        set => this.WithProperty("permission_model", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The template_body attribute.
    /// </summary>
    public TerraformProperty<string>? TemplateBody
    {
        get => GetProperty<TerraformProperty<string>>("template_body");
        set => this.WithProperty("template_body", value);
    }

    /// <summary>
    /// The template_url attribute.
    /// </summary>
    public TerraformProperty<string>? TemplateUrl
    {
        get => GetProperty<TerraformProperty<string>>("template_url");
        set => this.WithProperty("template_url", value);
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
