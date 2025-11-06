using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_organization_policy resource.
/// </summary>
public class GoogleOrganizationPolicy : TerraformResource
{
    public GoogleOrganizationPolicy(string name) : base("google_organization_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("etag");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// The name of the Constraint the Policy is configuring, for example, serviceuser.services.
    /// </summary>
    public string? Constraint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("constraint")?.Value;
        set => this.WithProperty("constraint", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The org_id attribute.
    /// </summary>
    public string? OrgId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("org_id")?.Value;
        set => this.WithProperty("org_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Version of the Policy. Default version is 0.
    /// </summary>
    public double? Version
    {
        get => GetProperty<TerraformLiteralProperty<double>>("version")?.Value;
        set => this.WithProperty("version", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The etag of the organization policy. etag is used for optimistic concurrency control as a way to help prevent simultaneous updates of a policy from overwriting each other.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// The timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, accurate to nanoseconds, representing when the variable was last updated. Example: &amp;quot;2016-10-09T12:33:37.578138407Z&amp;quot;.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
