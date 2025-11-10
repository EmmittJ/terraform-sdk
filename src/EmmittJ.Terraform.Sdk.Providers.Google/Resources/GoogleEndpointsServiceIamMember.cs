using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for condition in .
/// Nesting mode: list
/// </summary>
public class GoogleEndpointsServiceIamMemberConditionBlock : TerraformBlock
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => WithProperty("description", value);
    }

    /// <summary>
    /// The expression attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Expression is required")]
    public required TerraformProperty<string> Expression
    {
        get => GetProperty<TerraformProperty<string>>("expression");
        set => WithProperty("expression", value);
    }

    /// <summary>
    /// The title attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Title is required")]
    public required TerraformProperty<string> Title
    {
        get => GetProperty<TerraformProperty<string>>("title");
        set => WithProperty("title", value);
    }

}

/// <summary>
/// Manages a google_endpoints_service_iam_member resource.
/// </summary>
public class GoogleEndpointsServiceIamMember : TerraformResource
{
    public GoogleEndpointsServiceIamMember(string name) : base("google_endpoints_service_iam_member", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("etag");
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
    /// The member attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Member is required")]
    public required TerraformProperty<string> Member
    {
        get => GetProperty<TerraformProperty<string>>("member");
        set => this.WithProperty("member", value);
    }

    /// <summary>
    /// The role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Role is required")]
    public required TerraformProperty<string> Role
    {
        get => GetProperty<TerraformProperty<string>>("role");
        set => this.WithProperty("role", value);
    }

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceName is required")]
    public required TerraformProperty<string> ServiceName
    {
        get => GetProperty<TerraformProperty<string>>("service_name");
        set => this.WithProperty("service_name", value);
    }

    /// <summary>
    /// Block for condition.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Condition block(s) allowed")]
    public List<GoogleEndpointsServiceIamMemberConditionBlock>? Condition
    {
        get => GetProperty<List<GoogleEndpointsServiceIamMemberConditionBlock>>("condition");
        set => this.WithProperty("condition", value);
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

}
