using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsQuicksightAccountSubscriptionTimeoutsBlock : TerraformBlock
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
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Manages a aws_quicksight_account_subscription resource.
/// </summary>
public class AwsQuicksightAccountSubscription : TerraformResource
{
    public AwsQuicksightAccountSubscription(string name) : base("aws_quicksight_account_subscription", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("account_subscription_status");
        SetOutput("account_name");
        SetOutput("active_directory_name");
        SetOutput("admin_group");
        SetOutput("admin_pro_group");
        SetOutput("authentication_method");
        SetOutput("author_group");
        SetOutput("author_pro_group");
        SetOutput("aws_account_id");
        SetOutput("contact_number");
        SetOutput("directory_id");
        SetOutput("edition");
        SetOutput("email_address");
        SetOutput("first_name");
        SetOutput("iam_identity_center_instance_arn");
        SetOutput("id");
        SetOutput("last_name");
        SetOutput("notification_email");
        SetOutput("reader_group");
        SetOutput("reader_pro_group");
        SetOutput("realm");
        SetOutput("region");
    }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    public required TerraformProperty<string> AccountName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("account_name");
        set => SetProperty("account_name", value);
    }

    /// <summary>
    /// The active_directory_name attribute.
    /// </summary>
    public TerraformProperty<string> ActiveDirectoryName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("active_directory_name");
        set => SetProperty("active_directory_name", value);
    }

    /// <summary>
    /// The admin_group attribute.
    /// </summary>
    public List<TerraformProperty<string>> AdminGroup
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("admin_group");
        set => SetProperty("admin_group", value);
    }

    /// <summary>
    /// The admin_pro_group attribute.
    /// </summary>
    public List<TerraformProperty<string>> AdminProGroup
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("admin_pro_group");
        set => SetProperty("admin_pro_group", value);
    }

    /// <summary>
    /// The authentication_method attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthenticationMethod is required")]
    public required TerraformProperty<string> AuthenticationMethod
    {
        get => GetRequiredOutput<TerraformProperty<string>>("authentication_method");
        set => SetProperty("authentication_method", value);
    }

    /// <summary>
    /// The author_group attribute.
    /// </summary>
    public List<TerraformProperty<string>> AuthorGroup
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("author_group");
        set => SetProperty("author_group", value);
    }

    /// <summary>
    /// The author_pro_group attribute.
    /// </summary>
    public List<TerraformProperty<string>> AuthorProGroup
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("author_pro_group");
        set => SetProperty("author_pro_group", value);
    }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    public TerraformProperty<string> AwsAccountId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("aws_account_id");
        set => SetProperty("aws_account_id", value);
    }

    /// <summary>
    /// The contact_number attribute.
    /// </summary>
    public TerraformProperty<string> ContactNumber
    {
        get => GetRequiredOutput<TerraformProperty<string>>("contact_number");
        set => SetProperty("contact_number", value);
    }

    /// <summary>
    /// The directory_id attribute.
    /// </summary>
    public TerraformProperty<string> DirectoryId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("directory_id");
        set => SetProperty("directory_id", value);
    }

    /// <summary>
    /// The edition attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Edition is required")]
    public required TerraformProperty<string> Edition
    {
        get => GetRequiredOutput<TerraformProperty<string>>("edition");
        set => SetProperty("edition", value);
    }

    /// <summary>
    /// The email_address attribute.
    /// </summary>
    public TerraformProperty<string> EmailAddress
    {
        get => GetRequiredOutput<TerraformProperty<string>>("email_address");
        set => SetProperty("email_address", value);
    }

    /// <summary>
    /// The first_name attribute.
    /// </summary>
    public TerraformProperty<string> FirstName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("first_name");
        set => SetProperty("first_name", value);
    }

    /// <summary>
    /// The iam_identity_center_instance_arn attribute.
    /// </summary>
    public TerraformProperty<string> IamIdentityCenterInstanceArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("iam_identity_center_instance_arn");
        set => SetProperty("iam_identity_center_instance_arn", value);
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
    /// The last_name attribute.
    /// </summary>
    public TerraformProperty<string> LastName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("last_name");
        set => SetProperty("last_name", value);
    }

    /// <summary>
    /// The notification_email attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NotificationEmail is required")]
    public required TerraformProperty<string> NotificationEmail
    {
        get => GetRequiredOutput<TerraformProperty<string>>("notification_email");
        set => SetProperty("notification_email", value);
    }

    /// <summary>
    /// The reader_group attribute.
    /// </summary>
    public List<TerraformProperty<string>> ReaderGroup
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("reader_group");
        set => SetProperty("reader_group", value);
    }

    /// <summary>
    /// The reader_pro_group attribute.
    /// </summary>
    public List<TerraformProperty<string>> ReaderProGroup
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("reader_pro_group");
        set => SetProperty("reader_pro_group", value);
    }

    /// <summary>
    /// The realm attribute.
    /// </summary>
    public TerraformProperty<string> Realm
    {
        get => GetRequiredOutput<TerraformProperty<string>>("realm");
        set => SetProperty("realm", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsQuicksightAccountSubscriptionTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The account_subscription_status attribute.
    /// </summary>
    public TerraformExpression AccountSubscriptionStatus => this["account_subscription_status"];

}
