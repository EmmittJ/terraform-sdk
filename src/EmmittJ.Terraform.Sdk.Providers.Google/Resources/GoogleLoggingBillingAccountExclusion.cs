using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_logging_billing_account_exclusion resource.
/// </summary>
public class GoogleLoggingBillingAccountExclusion : TerraformResource
{
    public GoogleLoggingBillingAccountExclusion(string name) : base("google_logging_billing_account_exclusion", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The billing_account attribute.
    /// </summary>
    public TerraformProperty<string>? BillingAccount
    {
        get => GetProperty<TerraformProperty<string>>("billing_account");
        set => this.WithProperty("billing_account", value);
    }

    /// <summary>
    /// A human-readable description.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// Whether this exclusion rule should be disabled or not. This defaults to false.
    /// </summary>
    public TerraformProperty<bool>? Disabled
    {
        get => GetProperty<TerraformProperty<bool>>("disabled");
        set => this.WithProperty("disabled", value);
    }

    /// <summary>
    /// The filter to apply when excluding logs. Only log entries that match the filter are excluded.
    /// </summary>
    public TerraformProperty<string>? Filter
    {
        get => GetProperty<TerraformProperty<string>>("filter");
        set => this.WithProperty("filter", value);
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
    /// The name of the logging exclusion.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

}
