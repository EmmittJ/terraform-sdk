using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_tags_tag_value_iam_policy.
/// </summary>
public class GoogleTagsTagValueIamPolicyDataSource : TerraformDataSource
{
    public GoogleTagsTagValueIamPolicyDataSource(string name) : base("google_tags_tag_value_iam_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("etag");
        this.DeclareOutput("policy_data");
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
    /// The tag_value attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TagValue
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tag_value");
        set => this.WithProperty("tag_value", value);
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// The policy_data attribute.
    /// </summary>
    public TerraformExpression PolicyData => this["policy_data"];

}
