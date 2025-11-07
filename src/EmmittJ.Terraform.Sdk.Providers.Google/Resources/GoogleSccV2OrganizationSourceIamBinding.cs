using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_scc_v2_organization_source_iam_binding resource.
/// </summary>
public class GoogleSccV2OrganizationSourceIamBinding : TerraformResource
{
    public GoogleSccV2OrganizationSourceIamBinding(string name) : base("google_scc_v2_organization_source_iam_binding", name)
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
    /// The organization attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Organization
    {
        get => GetProperty<TerraformLiteralProperty<string>>("organization");
        set => this.WithProperty("organization", value);
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
    /// The source attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Source
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source");
        set => this.WithProperty("source", value);
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

}
