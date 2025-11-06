using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_tags_tag_key_iam_member resource.
/// </summary>
public class GoogleTagsTagKeyIamMember : TerraformResource
{
    public GoogleTagsTagKeyIamMember(string name) : base("google_tags_tag_key_iam_member", name)
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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The member attribute.
    /// </summary>
    public string? Member
    {
        get => GetProperty<TerraformLiteralProperty<string>>("member")?.Value;
        set => this.WithProperty("member", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The role attribute.
    /// </summary>
    public string? Role
    {
        get => GetProperty<TerraformLiteralProperty<string>>("role")?.Value;
        set => this.WithProperty("role", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tag_key attribute.
    /// </summary>
    public string? TagKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tag_key")?.Value;
        set => this.WithProperty("tag_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

}
