using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_account_alternate_contact resource.
/// </summary>
public class AwsAccountAlternateContact : TerraformResource
{
    public AwsAccountAlternateContact(string name) : base("aws_account_alternate_contact", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    public TerraformProperty<string>? AccountId
    {
        get => GetProperty<TerraformProperty<string>>("account_id");
        set => this.WithProperty("account_id", value);
    }

    /// <summary>
    /// The alternate_contact_type attribute.
    /// </summary>
    public TerraformProperty<string>? AlternateContactType
    {
        get => GetProperty<TerraformProperty<string>>("alternate_contact_type");
        set => this.WithProperty("alternate_contact_type", value);
    }

    /// <summary>
    /// The email_address attribute.
    /// </summary>
    public TerraformProperty<string>? EmailAddress
    {
        get => GetProperty<TerraformProperty<string>>("email_address");
        set => this.WithProperty("email_address", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    public TerraformProperty<string>? PhoneNumber
    {
        get => GetProperty<TerraformProperty<string>>("phone_number");
        set => this.WithProperty("phone_number", value);
    }

    /// <summary>
    /// The title attribute.
    /// </summary>
    public TerraformProperty<string>? Title
    {
        get => GetProperty<TerraformProperty<string>>("title");
        set => this.WithProperty("title", value);
    }

}
