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
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The policy_data attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyData is required")]
    public required TerraformProperty<string> PolicyData
    {
        get => GetProperty<TerraformProperty<string>>("policy_data");
        set => this.WithProperty("policy_data", value);
    }

    /// <summary>
    /// The tag_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TagKey is required")]
    public required TerraformProperty<string> TagKey
    {
        get => GetProperty<TerraformProperty<string>>("tag_key");
        set => this.WithProperty("tag_key", value);
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

}
