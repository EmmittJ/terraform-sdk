using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_discovery_engine_license_config resource.
/// </summary>
public class GoogleDiscoveryEngineLicenseConfig : TerraformResource
{
    public GoogleDiscoveryEngineLicenseConfig(string name) : base("google_discovery_engine_license_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("name");
    }

    /// <summary>
    /// Whether the license config should be auto renewed when it reaches the end date.
    /// </summary>
    public bool? AutoRenew
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("auto_renew")?.Value;
        set => this.WithProperty("auto_renew", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Whether the license config is for free trial.
    /// </summary>
    public bool? FreeTrial
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("free_trial")?.Value;
        set => this.WithProperty("free_trial", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The unique id of the license config.
    /// </summary>
    public string? LicenseConfigId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("license_config_id")?.Value;
        set => this.WithProperty("license_config_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Number of licenses purchased.
    /// </summary>
    public double? LicenseCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("license_count")?.Value;
        set => this.WithProperty("license_count", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The geographic location where the data store should reside. The value can
    /// only be one of &amp;quot;global&amp;quot;, &amp;quot;us&amp;quot; and &amp;quot;eu&amp;quot;.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// Subscription term. Possible values: [&amp;quot;SUBSCRIPTION_TERM_UNSPECIFIED&amp;quot;, &amp;quot;SUBSCRIPTION_TERM_ONE_MONTH&amp;quot;, &amp;quot;SUBSCRIPTION_TERM_ONE_YEAR&amp;quot;, &amp;quot;SUBSCRIPTION_TERM_THREE_YEARS&amp;quot;, &amp;quot;SUBSCRIPTION_TERM_THREE_MONTHS&amp;quot;, &amp;quot;SUBSCRIPTION_TERM_FOURTEEN_DAYS&amp;quot;, &amp;quot;SUBSCRIPTION_TERM_CUSTOM&amp;quot;]
    /// </summary>
    public string? SubscriptionTerm
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subscription_term")?.Value;
        set => this.WithProperty("subscription_term", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Subscription tier information for the license config. Possible values: [&amp;quot;SUBSCRIPTION_TIER_UNSPECIFIED&amp;quot;, &amp;quot;SUBSCRIPTION_TIER_SEARCH&amp;quot;, &amp;quot;SUBSCRIPTION_TIER_SEARCH_AND_ASSISTANT&amp;quot;, &amp;quot;SUBSCRIPTION_TIER_NOTEBOOK_LM&amp;quot;, &amp;quot;SUBSCRIPTION_TIER_FRONTLINE_WORKER&amp;quot;, &amp;quot;SUBSCRIPTION_TIER_AGENTSPACE_STARTER&amp;quot;, &amp;quot;SUBSCRIPTION_TIER_AGENTSPACE_BUSINESS&amp;quot;, &amp;quot;SUBSCRIPTION_TIER_ENTERPRISE&amp;quot;, &amp;quot;SUBSCRIPTION_TIER_EDU&amp;quot;, &amp;quot;SUBSCRIPTION_TIER_EDU_PRO&amp;quot;]
    /// </summary>
    public string? SubscriptionTier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subscription_tier")?.Value;
        set => this.WithProperty("subscription_tier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The unique full resource name of the license config. Values are of the format
    /// &#39;projects/{project}/locations/{location}/licenseConfigs/{license_config}&#39;.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
