using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_scc_source_iam_policy.
/// </summary>
public class GoogleSccSourceIamPolicyDataSource : TerraformDataSource
{
    public GoogleSccSourceIamPolicyDataSource(string name) : base("google_scc_source_iam_policy", name)
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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The organization attribute.
    /// </summary>
    public string? Organization
    {
        get => GetProperty<TerraformLiteralProperty<string>>("organization")?.Value;
        set => this.WithProperty("organization", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The source attribute.
    /// </summary>
    public string? Source
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source")?.Value;
        set => this.WithProperty("source", value == null ? null : new TerraformLiteralProperty<string>(value));
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
