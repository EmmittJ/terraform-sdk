using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_beyondcorp_security_gateway_application_iam_policy.
/// </summary>
public class GoogleBeyondcorpSecurityGatewayApplicationIamPolicyDataSource : TerraformDataSource
{
    public GoogleBeyondcorpSecurityGatewayApplicationIamPolicyDataSource(string name) : base("google_beyondcorp_security_gateway_application_iam_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("etag");
        this.DeclareOutput("policy_data");
    }

    /// <summary>
    /// The application_id attribute.
    /// </summary>
    public TerraformProperty<string>? ApplicationId
    {
        get => GetProperty<TerraformProperty<string>>("application_id");
        set => this.WithProperty("application_id", value);
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
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The security_gateway_id attribute.
    /// </summary>
    public TerraformProperty<string>? SecurityGatewayId
    {
        get => GetProperty<TerraformProperty<string>>("security_gateway_id");
        set => this.WithProperty("security_gateway_id", value);
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
