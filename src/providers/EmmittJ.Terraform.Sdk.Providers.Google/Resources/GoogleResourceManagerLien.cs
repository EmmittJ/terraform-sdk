using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleResourceManagerLienTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

}

/// <summary>
/// Manages a google_resource_manager_lien resource.
/// </summary>
public class GoogleResourceManagerLien : TerraformResource
{
    public GoogleResourceManagerLien(string name) : base("google_resource_manager_lien", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// A stable, user-visible/meaningful string identifying the origin
    /// of the Lien, intended to be inspected programmatically. Maximum length of
    /// 200 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Origin is required")]
    [TerraformPropertyName("origin")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Origin { get; set; }

    /// <summary>
    /// A reference to the resource this Lien is attached to.
    /// The server will validate the parent against those for which Liens are supported.
    /// Since a variety of objects can have Liens against them, you must provide the type
    /// prefix (e.g. &amp;quot;projects/my-project-name&amp;quot;).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    [TerraformPropertyName("parent")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Parent { get; set; }

    /// <summary>
    /// Concise user-visible strings indicating why an action cannot be performed
    /// on a resource. Maximum length of 200 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Reason is required")]
    [TerraformPropertyName("reason")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Reason { get; set; }

    /// <summary>
    /// The types of operations which should be blocked as a result of this Lien.
    /// Each value should correspond to an IAM permission. The server will validate
    /// the permissions against those for which Liens are supported.  An empty
    /// list is meaningless and will be rejected.
    /// e.g. [&#39;resourcemanager.projects.delete&#39;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Restrictions is required")]
    [TerraformPropertyName("restrictions")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<List<TerraformProperty<string>>>? Restrictions { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleResourceManagerLienTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Time of creation
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// A system-generated unique identifier for this Lien.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

}
