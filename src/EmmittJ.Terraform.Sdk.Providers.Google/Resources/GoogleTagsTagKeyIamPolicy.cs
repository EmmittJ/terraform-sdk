using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_tags_tag_key_iam_policy resource.
/// </summary>
public class GoogleTagsTagKeyIamPolicy : TerraformResource
{
    public GoogleTagsTagKeyIamPolicy(string name) : base("google_tags_tag_key_iam_policy", name)
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
    /// The policy_data attribute.
    /// </summary>
    public string? PolicyData
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy_data")?.Value;
        set => this.WithProperty("policy_data", value == null ? null : new TerraformLiteralProperty<string>(value));
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
