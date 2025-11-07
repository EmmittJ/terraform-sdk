using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_data_catalog_policy_tag_iam_binding resource.
/// </summary>
public class GoogleDataCatalogPolicyTagIamBinding : TerraformResource
{
    public GoogleDataCatalogPolicyTagIamBinding(string name) : base("google_data_catalog_policy_tag_iam_binding", name)
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
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The members attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? Members
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("members");
        set => this.WithProperty("members", value);
    }

    /// <summary>
    /// The policy_tag attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PolicyTag
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy_tag");
        set => this.WithProperty("policy_tag", value);
    }

    /// <summary>
    /// The role attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Role
    {
        get => GetProperty<TerraformLiteralProperty<string>>("role");
        set => this.WithProperty("role", value);
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

}
