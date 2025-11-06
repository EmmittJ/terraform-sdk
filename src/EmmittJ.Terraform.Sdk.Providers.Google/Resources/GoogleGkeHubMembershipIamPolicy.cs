using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_gke_hub_membership_iam_policy resource.
/// </summary>
public class GoogleGkeHubMembershipIamPolicy : TerraformResource
{
    public GoogleGkeHubMembershipIamPolicy(string name) : base("google_gke_hub_membership_iam_policy", name)
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
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The membership_id attribute.
    /// </summary>
    public string? MembershipId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("membership_id")?.Value;
        set => this.WithProperty("membership_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

}
