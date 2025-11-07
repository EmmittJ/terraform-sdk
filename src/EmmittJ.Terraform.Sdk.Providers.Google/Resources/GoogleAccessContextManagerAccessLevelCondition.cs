using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_access_context_manager_access_level_condition resource.
/// </summary>
public class GoogleAccessContextManagerAccessLevelCondition : TerraformResource
{
    public GoogleAccessContextManagerAccessLevelCondition(string name) : base("google_access_context_manager_access_level_condition", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("access_policy_id");
    }

    /// <summary>
    /// The name of the Access Level to add this condition to.
    /// </summary>
    public TerraformLiteralProperty<string>? AccessLevel
    {
        get => GetProperty<TerraformLiteralProperty<string>>("access_level");
        set => this.WithProperty("access_level", value);
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
    /// A list of CIDR block IP subnetwork specification. May be IPv4
    /// or IPv6.
    /// Note that for a CIDR IP address block, the specified IP address
    /// portion must be properly truncated (i.e. all the host bits must
    /// be zero) or the input is considered malformed. For example,
    /// &amp;quot;192.0.2.0/24&amp;quot; is accepted but &amp;quot;192.0.2.1/24&amp;quot; is not. Similarly,
    /// for IPv6, &amp;quot;2001:db8::/32&amp;quot; is accepted whereas &amp;quot;2001:db8::1/32&amp;quot;
    /// is not. The originating IP of a request must be in one of the
    /// listed subnets in order for this Condition to be true.
    /// If empty, all IP addresses are allowed.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? IpSubnetworks
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("ip_subnetworks");
        set => this.WithProperty("ip_subnetworks", value);
    }

    /// <summary>
    /// An allowed list of members (users, service accounts).
    /// Using groups is not supported yet.
    /// 
    /// The signed-in user originating the request must be a part of one
    /// of the provided members. If not specified, a request may come
    /// from any user (logged in/not logged in, not present in any
    /// groups, etc.).
    /// Formats: &#39;user:{emailid}&#39;, &#39;serviceAccount:{emailid}&#39;
    /// </summary>
    public TerraformLiteralProperty<List<string>>? Members
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("members");
        set => this.WithProperty("members", value);
    }

    /// <summary>
    /// Whether to negate the Condition. If true, the Condition becomes
    /// a NAND over its non-empty fields, each field must be false for
    /// the Condition overall to be satisfied. Defaults to false.
    /// </summary>
    public TerraformLiteralProperty<bool>? Negate
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("negate");
        set => this.WithProperty("negate", value);
    }

    /// <summary>
    /// The request must originate from one of the provided
    /// countries/regions.
    /// Format: A valid ISO 3166-1 alpha-2 code.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? Regions
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("regions");
        set => this.WithProperty("regions", value);
    }

    /// <summary>
    /// A list of other access levels defined in the same Policy,
    /// referenced by resource name. Referencing an AccessLevel which
    /// does not exist is an error. All access levels listed must be
    /// granted for the Condition to be true.
    /// Format: accessPolicies/{policy_id}/accessLevels/{short_name}
    /// </summary>
    public TerraformLiteralProperty<List<string>>? RequiredAccessLevels
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("required_access_levels");
        set => this.WithProperty("required_access_levels", value);
    }

    /// <summary>
    /// The name of the Access Policy this resource belongs to.
    /// </summary>
    public TerraformExpression AccessPolicyId => this["access_policy_id"];

}
