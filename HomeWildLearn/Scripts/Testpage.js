 Draggable.create(".icon", {
        bounds: "svg",
        onDrag: function () {
            if (this.hitTest("#bag")) {
                gsap.to(this.target, { duration: 0.6, opacity: 0, scale: 0, svgOrigin: "675 143" });
            }
        }
    });