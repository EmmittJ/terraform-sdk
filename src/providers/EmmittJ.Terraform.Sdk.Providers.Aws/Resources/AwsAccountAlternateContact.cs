using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsAccountAlternateContactTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

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
        SetOutput("account_id");
        SetOutput("alternate_contact_type");
        SetOutput("email_address");
        SetOutput("id");
        SetOutput("name");
        SetOutput("phone_number");
        SetOutput("title");
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    public TerraformProperty<string> AccountId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("account_id");
        set => SetProperty("account_id", value);
    }

    /// <summary>
    /// The alternate_contact_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AlternateContactType is required")]
    public required TerraformProperty<string> AlternateContactType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("alternate_contact_type");
        set => SetProperty("alternate_contact_type", value);
    }

    /// <summary>
    /// The email_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EmailAddress is required")]
    public required TerraformProperty<string> EmailAddress
    {
        get => GetRequiredOutput<TerraformProperty<string>>("email_address");
        set => SetProperty("email_address", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PhoneNumber is required")]
    public required TerraformProperty<string> PhoneNumber
    {
        get => GetRequiredOutput<TerraformProperty<string>>("phone_number");
        set => SetProperty("phone_number", value);
    }

    /// <summary>
    /// The title attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Title is required")]
    public required TerraformProperty<string> Title
    {
        get => GetRequiredOutput<TerraformProperty<string>>("title");
        set => SetProperty("title", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsAccountAlternateContactTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
